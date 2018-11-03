--创建CompanyStructure表,公司组织架构
use AttReport
go
if exists(select*from sysobjects where name='CompanyStructure')
drop table CompanyStructure
go
create table CompanyStructure
(
  CyName varchar(20) not null,--公司名
  CyDepartment varchar(10) not null,--部门名
  CyGroup varchar(10) not null,--组别
)
go
