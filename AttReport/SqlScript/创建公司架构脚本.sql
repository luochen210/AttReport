--创建CompanyStructure表,公司组织架构
use AttReport
go

if exists(select*from sysobjects where name='Company')
drop table Company
go
create table Company
(
  CompanyId int not null PRIMARY KEY IDENTITY(1,1),--公司ID
  CompanyName varchar(60) not null,--公司名称（需设自增长），1个汉字占3个字符
)
go

if exists(select*from sysobjects where name='Department')
drop table Department
go
create table Department
(
  DepartmentId int not null PRIMARY KEY IDENTITY(1,1),--部门ID
  DepartmentName varchar(21) not null,--部门名称
  CyId int not null FOREIGN KEY (CyId) REFERENCES Company(CompanyId),--外键  
)
go

if exists(select*from sysobjects where name='DtGroup')
drop table DtGroup
go
create table DtGroup
(
  DtGroupId int not null PRIMARY KEY IDENTITY(1,1),--组别ID
  DtGroupName varchar(21) not null,--组别名称
  DtId int not null FOREIGN KEY (DtId) REFERENCES Department(DepartmentID),--部门关联ID
  
)
go

if exists(select*from sysobjects where name='JobList')
drop table JobList
go
create table JobList
(  
  JobId int not null PRIMARY KEY IDENTITY(1,1),--职位ID，自增列
  JobName varchar(21) not null,--职位名称
  DpId int not null FOREIGN KEY (DpId) REFERENCES DtGroup(DtGroupId),--组别关联ID
  
)