CREATE TABLE [tbl_ServiceType] (
  [Id]  [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

CREATE TABLE [tbl_UserUserType] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int,
  [UserType_Id] int,
  [IsMain] bit
);

CREATE TABLE [tbl_SaleType] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

CREATE TABLE [tbl_EntityType] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

CREATE TABLE [tbl_Price] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Object_Id] int,
  [EntityType_Id] int,
  [Status_Id] int,
  [UnitType_Id] int,
  [SaleType_Id] int,
  [PriceInitial] decimal(7,2),
  [PriceDelivery] decimal(7,2),
  [PriceInsurance] decimal(7,2),
  [PriceInstallation] decimal(7,2),
  [PriceTax] decimal(7,2),
  [PriceFees] decimal(7,2),
  [PriceTotal] decimal(7,2),
  [PriceDiscount] decimal(7,2),
  [PriceMinimum] decimal(7,2),
  [PriceMaximum] decimal(7,2),
  [AmountMinimum] int,
  [AmountMaximum] int,
  [Currency] varchar,
  [Description] varchar,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Account] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int ,
  [Status_Id] int ,
  [AccountNumber] int,
  [BranchNumber] int,
  [BankNumber] int,
  [DateCreated] datetime,
  [DateModified] datetime ,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_ContactType] (
  [Id] int,
  [Type] varchar
);

CREATE TABLE [tbl_UserType] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

CREATE TABLE [tbl_Review] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Object_Id] int,
  [EntityType_Id] int,
  [Status_Id] int,
  [User_Id] int,
  [UserReceiving_Id] int,
  [Order_Id] int,
  [OrderPackage_Id] int,
  [Rating] int,
  [Title] varchar,
  [Content] varchar,
  [IsComplaint] bit,
  [IsResolved] bit,
  [DateCreated] datetime,
  [DateModified] datetime ,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Order] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Object_Id] int,
  [EntityType_Id] int,
  [OrderPackage_Id] int,
  [User_Id] int,
  [UserOffering_Id] int,
  [Contact_Id] int,
  [Price_Id] int,
  [Status_Id] int,
  [Timeline_Id] int,
  [Check_Id] int,
  [ServiceDelivery_Id] int,
  [ServiceInstallation_Id] int,
  [ServiceInsurance_Id] int,
  [Discount_Id] int,
  [Amount] int ,
  [PublicId] UNIQUEIDENTIFIER ,
  [Description] varchar,
  [Notes] varchar,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Service] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [ServiceType_Id] int,
  [User_Id] int,
  [Status_ Id] int,
  [Check_Id] int,
  [PublicId ] UNIQUEIDENTIFIER ,
  [Name] varchar,
  [Description] varchar,
  [Code] varchar,
  [Category] nvarchar(max),
  [Keywords] nvarchar(max),
  [DateCreated] datetime,
  [DateModified] datetime ,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_ProductType] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

CREATE TABLE [tbl_UnitType] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

CREATE TABLE [tbl_UserFavourite] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int,
  [Object_Id] int,
  [EntityType_Id] int,
  [Status_Id] int,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_UserLocation] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int,
  [Location_Id] int,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Check] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [IsForSale ] bit,
  [IsRental] bit,
  [IsPercentage] bit,
  [IsNew ] bit,
  [IsConfirmationRequired] bit,
  [IsDeliveryReuired] bit,
  [IsDeliveryOffered] bit,
  [IsDeliveryFree] bit,
  [IsInsuranceRequired] bit,
  [IsInsuranceOffered] bit,
  [IsInsuranceFree] bit,
  [IsAssemblyRequired] bit,
  [IsAssemblyOffered] bit,
  [IsAssemblyFree] bit,
  [IsServiceRequired] bit,
  [IsProductRequired] bit,
  [IsCodeRequired] bit,
  [IsActive] bit,
  [IsFeatured] bit,
  [IsPremium] bit,
  [IsOffer] bit,
  [IsRequest] bit,
  [IsFavourite] bit,
  [IsCompleted] bit,
  [IsConfirmed] bit,
  [IsMain] bit
);

CREATE TABLE [tbl_User] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Status_Id] int,
  [Check_Id] int,
  [PasswordHash] VARBINARY,
  [PasswordSalt] VARBINARY,
  [UserName] varchar,
  [PublicName] varchar,
  [Biography] varchar,
  [Gender] varchar,
  [Requesting] nvarchar(max),
  [Offering] nvarchar(max),
  [Points] int,
  [Rating] int,
  [IsCorp] bit,
  [IsAdmin] bit,
  [DateOfBirth] datetime,
  [DateLastActive] datetime,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int 
);

CREATE TABLE [tbl_Timeline] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Object_Id] int,
  [EntityType_Id] int,
  [DateRequested] datetime ,
  [DateConfirmed] datetime ,
  [DateShipped] datetime ,
  [DateExpected] datetime ,
  [DateReceived] datetime ,
  [DateCompleted] datetime ,
  [DateLastUsed] datetime,
  [DateStarted] datetime,
  [DateEnded] datetime,
  [DateCreated] datetime ,
  [DateModified] datetime ,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Message] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Status_Id] int,
  [User_Id] int,
  [UserReceiving_Id] int,
  [Title] varchar,
  [Content] varchar,
  [IsRead] bit,
  [DateSent] datetime,
  [DateRead] datetime,
  [DateCreated] datetime,
  [DateModified] datetime ,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Product] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [ProductType_Id ] int,
  [User_Id] int,
  [Status_Id] int,
  [Check_Id] int,
  [Stock] int,
  [PublicId ] UNIQUEIDENTIFIER,
  [Name] varchar,
  [Description] varchar,
  [Dimensions] varchar,
  [DimensionsPackage] varchar,
  [Weight] varchar,
  [WeightPackage] varchar,
  [Colour] varchar,
  [Material] varchar,
  [Code] varchar,
  [Category] nvarchar(max),
  [Keywords] nvarchar(max),
  [DateBuilt] datetime,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int 
);

CREATE TABLE [tbl_Location] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [LocationType_Id] int,
  [Contact_Id] int,
  [Status_Id] int,
  [Price_Id] int,
  [Rooms] int,
  [Living] int,
  [Dining] int,
  [Kitchen] int,
  [Bedroom] int,
  [Stories] int,
  [Balcony] int,
  [Backyard] int,
  [PublicId] UNIQUEIDENTIFIER,
  [MLSId] varchar,
  [Size] varchar,
  [EntranceSize] varchar,
  [Description] varchar,
  [IsRenovated] bit,
  [IsTenant] bit,
  [IsEmpty] bit,
  [IsElevatorRequired] bit,
  [IsMain] bit,
  [IsFavourite] bit,
  [DateBuilt] datetime,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Discount] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Object_Id] int,
  [EntityType_Id] int,
  [User_Id] int,
  [Status_Id] int,
  [Check_Id] int,
  [Timeline_Id] int,
  [Percentage] int,
  [Amount] decimal(2,2),
  [Code] varchar,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Contact] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int,
  [Status_Id] int,
  [ContactType_Id] int,
  [LocationType_Id] int,
  [FirstName] varchar,
  [LastName] varchar,
  [Email] varchar,
  [PhoneAreaCode] int,
  [Extension] int,
  [Phone] varchar,
  [PhoneAdditional] varchar,
  [Address] varchar,
  [Unit] varchar,
  [Buzzer] varchar,
  [PostalCode] varchar,
  [City] varchar,
  [Province] varchar,
  [Country] varchar,
  [CountryCode] varchar,
  [Notes] varchar,
  [IsMain] bit,
  [IsFavourite] bit,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_OrderPackage] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int ,
  [OfferingUser_Id] int,
  [Status_Id] int,
  [Timeline_Id] int,
  [Price_Id] int,
  [Check_Id] int,
  [Location_Id] int,
  [PublicId] UNIQUEIDENTIFIER,
  [Description] varchar,
  [Notes] varchar,
  [DateCreated] datetime,
  [DateModified] datetime ,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_SocialMedia] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int,
  [Status_Id] int,
  [SocialMedia] varchar,
  [Link] varchar,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_EntityPrice] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Object_Id] int,
  [EntityType_Id] int,
  [Price_Id] int,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Photo] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Status_Id] int,
  [Object_Id] int,
  [EntityType_Id] int,
  [Index] int,
  [Url] varchar,
  [UrlPublic] varchar ,
  [Description] varchar,
  [IsMain] bit,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Transaction] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [User_Id] int,
  [Status_Id] int,
  [OrderPackage_Id] int,
  [ContactBilling_Id] int,
  [ContactShipping_Id] int,
  [Price] decimal(7,2),
  [Currency] varchar,
  [DataKey] varchar,
  [IsSuccessful] bit,
  [DateCompleted] datetime ,
  [DateCreated] datetime,
  [DateModified] datetime,
  [CreatedBy] int,
  [ModifiedBy] int
);

CREATE TABLE [tbl_Status] (
  [Id] [int] IDENTITY(1,1) NOT NULL,
  [Type] varchar
);

