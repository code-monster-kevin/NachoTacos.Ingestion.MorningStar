# Steps to add a new MorningStar Master entity to keep only the delta from Ingestion task temp table

## NachoTacos.Ingestion.MorningStar.Domain project
1. Copy TCompanyFinancialAvailability.cs to a new class MCompanyFinancialAvailability.cs

In the new class change pre-fix T to M, and the base class from TBase to Updatable
```
[Table("TCompanyFinancialAvailability", Schema = "MStar")]
public class TCompanyFinancialAvailability : TBase
```
to
```
[Table("MCompanyFinancialAvailability", Schema = "MStar")]
public class MCompanyFinancialAvailability : Updatable
```

2. Add a new Guid identity property to the M class
```
public Guid MCompanyFinancialAvailabilityId { get; set; }
```

3. Change the namespace from NachoTacos.Ingestion.MorningStar.Domain.MorningStar to NachoTacos.Ingestion.MorningStar.Domain
The classes are kept in the MorningStar folder for easier locating, but for the program, it's better to put into the same namespace.

## NachoTacos.Ingestion.MorningStar.Data project
1. In IngestionContext class, add a new DbSet MCompanyFinancialAvailability
```
public DbSet<MCompanyFinancialAvailability> MCompanyFinancialAvailabilities { get; set; }
```

2. Add the same to the interface IIngestionContext
```
DbSet<MCompanyFinancialAvailability> MCompanyFinancialAvailabilities { get; set; }
```

3. Open Package Manager Console and run add migration command and update the database
```
add-migration add-table-mcompanyfinancial
update-database
```

## Database
1. Create the MergeCompanyFinancial Stored Procedure to Merge from TCompanyFinancialAvailability to MCompanyFinancialAvailability
based on the latest TaskId as an input parameter
NOTE: Copy and paste from an existing Merge...sql and change as necessary


