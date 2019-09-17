CREATE VIEW [dbo].[FullCustomer]
	AS 
	SELECT [c].[CustomerId] as CustomerId, [c].[FirstName], [c].[MiddleName], 
	[c].[LastName], [a].[Id] as AddressId, [a].[StreetAddress], [a].[City], [a].[State], [a].[ZipCode]
	FROM dbo.Customer c
	left join dbo.Address a 
	 on c.[CustomerId] = a.CustomerId
