CREATE TABLE [dbo].[SensorData]
(
    [AreaName] varchar(10) NOT NULL,
    [TimeStamp] DateTime NOT NULL,
    [Resistance] decimal(10,3),
    [Voltage] decimal(10,3), 
    [Temperature] decimal(10,3), 
    [PHValue] int, 
    [DissolvedOxygen] decimal(10,3),
    [RadioIsotopeLevel] varchar(10), 
    [StableIsotopeLevel] varchar(10), 
	[CurrentSpeed] decimal(10,3), 
    [WaterLevel] decimal(10,3),
	PRIMARY KEY (AreaName, TimeStamp)
);
