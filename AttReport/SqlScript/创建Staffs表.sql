--创建员工表
use AttReport
go
if exists(select*from sysobjects where name='Staffs')
drop table Staffs
go
create table Staffs
(
  SfId int not null primary key identity(3000,1),--员工ID、考勤号、工号(自增长)
  AttCardNo varchar(21) not null default'待分配',--考勤卡号
  CyDepartment varchar(21) not null default'待分配',--部门名
  DtGroup varchar(21) not null default'待分配',--组别
  DpJob varchar(28) not null default'待分配',--职位
  SfName varchar(21) not null,--姓名
  SfGender varchar(21) not null,--性别
  SfMarriage varchar(6) not null,--婚姻
  SfEducation varchar(12) not null,--学历
  SfMajor varchar(12) not null,--专业
  SfNativePlace varchar(12) not null,--籍贯
  SfNation varchar(12) not null,--民族
  SfEntryDate datetime not null,--入职日期
  SfBirthDate datetime not null,--出生日期
  SfDomicile varchar(60) not null,--户籍地址
  SfResidence varchar(60) not null,--居住地
  SfIntroducer varchar(21) not null default'无',--推荐人
  SfFriend varchar(21) not null,--员工亲友/紧急联络人
  SfRelation varchar(12) not null,--亲友关系
  SfFriendsPhone varchar(21) not null,--亲友电话/紧急联络电话  
  SfStatus varchar(21) not null default'在职',--在职或离职
  SfShifts varchar(30)--轮班
  )
go