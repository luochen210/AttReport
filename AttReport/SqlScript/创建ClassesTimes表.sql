--创建班次表
use AttReport
go
if exists(select * from sysobjects where name='Classes')
drop table Classes
go
create table Classes
(
  ClassesId int not null,--班次ID
  ClassesName varchar(21) not null primary key,--班次名称
  EnableSTime datetime not null,--启用时间
  CycleNumber int not null,--周期数
  CycleUnit varchar(3) not null--周期单位
)
go


--创建班次时段表
if exists (select * from sysobjects where name='ClassesTimes')
drop table ClassesTimes
go
create table ClassesTimes
(
  ClassesId int not null primary key identity(1,1),--班次ID
  ClassesName varchar(24) not null,--班次名称
  TimesName1 varchar(24) not null,--时间段名称1
  TimesName2 varchar(24) not null,--时间段名称2
  TimesName3 varchar(24), --时段名称3
  Monday bit not null,--星期一，1代表true,0代表false
  Tuesday bit not null,--星期二
  Wednesday bit not null,--星期三
  Thursday bit not null,--星期四
  Friday bit not null,--星期五
  Saturday bit not null,--星期六
  Sunday bit not null--星期日
)
go