# NachoTacos.Ingestion.MorningStar
This project pulls data from Morningstar for storage

## Steps to ingesting a new MorningStar API

### NachoTacos.Ingestion.MorningStar.Api Project
1. Create a subfolder matching the Data Catalog Folder in the EquityApi
 ie. "CompanyFinancials"

2. In the new folder, create Request, Response, and Entity classes
  note: You can use Copy XML to classes to generate the response entities

3. Change the datatype to match the MorningStar Data Catalog

### NachoTacos.Ingestion.MorningStar.Domain Project
1. In the MorningStar folder, create the matching classes to store in database
ie. Copy and paste the related classes from the NachoTacos.Ingestion.MorningStar.Api Project

2. Make sure the newly created class inherits from TBase class
This will add the additional properties needed to track the ingestion task for this set of data

### NachoTacos.Ingestion.MorningStar.Data Project
1. Add the newly created classes in the Domain project to the IngestionContext DbSet
Note: Remember to add the same to the IIngestionContext interface


### NachoTacos.Ingestion.MorningStar.Api Project
1. In the AutoMapping.cs add the automapping references to Map the EquityApi classes to the Domain classes
```
  CreateMap<StockExchangeSecurityEntity, TStockExchangeSecurity>();
```

2. Add the method to save the new Response to the database in the NachoTacos.Ingestion.MorningStar.Api.Services.PersistenceService class

3. Create the controller to create a request, get the response, and persist to db