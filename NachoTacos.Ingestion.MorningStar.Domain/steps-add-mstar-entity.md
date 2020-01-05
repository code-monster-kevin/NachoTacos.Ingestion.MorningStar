# Steps to add a new MorningStar entity to save to database
Example Step for creating the BalanceSheetEntity

## NachoTacos.Ingestion.MorningStar.Domain project
1. Create a new domain model in the MorningStar folder "TBalanceSheet.cs"

2. Rename the namespace NachoTacos.Ingestion.MorningStar.Domain.MorningStar to NachoTacos.Ingestion.MorningStar.Domain 

3. From the project NachoTacos.Ingestion.MorningStar.Api.EquityApi
   Copy and paste the BalanceSheetEntity.cs class to TBalanceSheet.cs class

4. Rename the class to TBalanceSheet and set the schema to MStar
```
public partial class BalanceSheetEntity
to
[Table("TBalanceSheet", Schema = "MStar")]
public class TBalanceSheet
```

5. Add 2 additional properties for tracking purposes
```
public Guid Id { get; set; }
public Guid IngestionTaskId { get; set; }
```


## NachoTacos.Ingestion.MorningStar.Data project
1. In IngestionContext class, add a new DbSet TBalanceSheets
```
public DbSet<TBalanceSheet> TBalanceSheets { get; set; }
```

2. Add the same to the interface IIngestionContext
```
DbSet<TBalanceSheet> TBalanceSheets { get; set; }
```

3. Open Package Manager Console and run add migration command and update the database
```
add-migration add-table-tbalancesheet
update-database
```

## NachoTacos.Ingestion.MorningStar.Api project
1. In AutoMapping.cs class, create the new mapping
```
CreateMap<BalanceSheetEntity, TBalanceSheet>();
```

2. In PersistenceService.cs class, add the new Save function that takes in the parameters
(EquityApi.BalanceSheet.Request request, List<BalanceSheetEntity> entities)
and add the code that maps BalanceSheetEntity to TBalanceSheet and save to database
```
public async Task<int> Save(EquityApi.BalanceSheet.Request request, List<BalanceSheetEntity> entities)
        {
            try
            {
                string entityName = "BalanceSheetEntity";
                ValidateEntities(entities, entityName);

                IngestionTask ingestionTask = IngestionTask.Create(entityName, JsonConvert.SerializeObject(request));
                _ingestionContext.IngestionTasks.Add(ingestionTask);

                List<TBalanceSheet> list = new List<TBalanceSheet>();
                foreach (var entity in entities)
                {
                    TBalanceSheet item = _mapper.Map<TBalanceSheet>(entity);
                    item.TBalanceSheetId = Guid.NewGuid();
                    item.IngestionTaskId = ingestionTask.IngestionTaskId;

                    list.Add(item);
                }
                _ingestionContext.TBalanceSheets.AddRange(list);
                return await _ingestionContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
```
NOTE: There is still some repetitive code, might be room for refactoring... but that will be for another time


