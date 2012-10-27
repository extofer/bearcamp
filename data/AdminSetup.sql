USE bearcamp;


INSERT INTO [bearcamp].[dbo].[Users]
           ([UserLogin]
           ,[Pswd]
           ,[FirstName]
           ,[LastName]
           ,[Email]
           ,[Phone])
     VALUES
           ('admin'
           ,'password'
           ,'Admin'
           ,'User'
           ,'me@me.com'
           ,'5555555555')
GO

INSERT INTO [bearcamp].[dbo].[Feature]
           ([FeatureName])
     VALUES
           ('Admin')
GO

INSERT INTO [bearcamp].[dbo].[Permission]
           ([UserLogin]
           ,[FeatureID]
           ,[PermissionSort])
     VALUES
           ('Admin'
           ,(SELECT FeatureID from dbo.Feature WHERE FeatureName = 'Admin')
           ,10)
GO


