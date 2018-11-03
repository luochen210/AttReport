--创建JobList表,用于员工录入时使用
use AttReport
go
if exists(select*from sysobjects where name='JobList')
drop table JobList
go
create table JobList
(  
  JobID int PRIMARY KEY IDENTITY(1,1),--职位ID，自增列
  JobName varchar(10) not null,--职位名称
  DepartmentName varchar(10) not null,--部门名称
  DepartmentID int not null,--部门ID
  
)
go
