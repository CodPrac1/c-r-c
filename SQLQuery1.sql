SELECT TOP (1000) [Id]
      ,[Code]
      ,[Name]
      ,[RegionImageUrl]
  FROM [SampleWebAPIDb].[dbo].[Regions];

 use SampleWebAPIDb
 go
  Insert into Regions
  ([Id] ,[Code] ,[Name] ,[RegionImageUrl])
  values ('A97dfgdss2C577-DFB0-064E-1189-0154C99310DAAC12', 'KP', 'Auckland', 'image.jpg');

   Insert into Regions
  ([Id] ,[Code] ,[Name] ,[RegionImageUrl])
  values ('A97dfgdss2C577-DFB0-064E-1189-0154C9931dsgdg0DAAC12', 'TK', 'Tarnaka', 'image.jpg');