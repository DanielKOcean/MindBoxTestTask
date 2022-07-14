create table dbo.Product
(
	ProductId int primary key,
	ProductName nvarchar(128) not null
);

insert
	into
	dbo.Product(ProductId,
	ProductName)
values (1,
N'PC AMD Rizen5600 for Students');

insert
	into
	dbo.Product(ProductId,
	ProductName)
values (2,
N'Video Card NVidia RTX3070Ti');

insert
	into
	dbo.Product(ProductId,
	ProductName)
values (3,
N'Picture Frame 20cm x 30cm');

create table dbo.Category
(
	CategoryId int primary key,
	CategoryName nvarchar(64) not null
);

insert
	into
	dbo.Category(CategoryId,
	CategoryName)
values (1,
N'Electronics');

insert
	into
	dbo.Category(CategoryId,
	CategoryName)
values (2,
N'Study');

create table dbo.ProductCategory
(
	ProductId int foreign key references dbo.Product(ProductId),
	CategoryId int foreign key references dbo.Category(CategoryId),
	primary key(ProductId,
CategoryId)
);

insert
	into
	dbo.ProductCategory(ProductId,
	CategoryId)
values (1,
1);

insert
	into
	dbo.ProductCategory(ProductId,
	CategoryId)
values (1,
2);

insert
	into
	dbo.ProductCategory(ProductId,
	CategoryId)
values (2,
1);

select
	p.ProductName,
	c.CategoryName
from
	dbo.Product p
left join dbo.ProductCategory pc on
	p.ProductId = pc.ProductId
left join dbo.Category c on
	c.CategoryId = pc.CategoryId;