use master
go
--判断当前数据库是否存在
if exists(select * from sysdatabases where name='AttReport' )
drop database AttReport
go
--创建数据库
create database AttReport
go

------------

--创建数据表
use AttReport
go

 --创建公司表
if exists(select*from sysobjects where name='Company')
drop table Company
go
create table Company
(
  CompanyId int not null PRIMARY KEY IDENTITY(1,1),--公司ID，从1开始自增长
  CompanyName varchar(60) not null,--公司名称，1个汉字占3个字符
)
go

--创建部门表
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

--创建组别表
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

--创建职位表
if exists(select*from sysobjects where name='JobList')
drop table JobList
go
create table JobList
(  
  JobId int not null PRIMARY KEY IDENTITY(1,1),--职位ID，自增列
  JobName varchar(21) not null,--职位名称  
)
go

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

--创建班次时间表
use AttReport
go

if exists (select * from sysobjects where name='TimesManage')
drop table TimesManage
go
create table TimesManage
(
  TimesId int not null primary key identity(1,1),--时段ID
  TimesName varchar(18) not null ,--时间段名称
  WorkTime varchar(18) not null,--上班时间
  OffDutyTime varchar(18) not null,--下班时间
  StartCheckIn varchar(18) not null,--开始签到
  EndCheckIn varchar(18) not null,--结束签到
  StartSignBack varchar(18) not null,--开始签退
  EndSignBack varchar(18) not null,--结束签退
  LateTime int not null,--迟到时间数，计分钟
  LeftEarly int not null,--早退时间数，计分钟
)
go

--创建员工表
use AttReport
go
if exists(select*from sysobjects where name='Staffs')
drop table Staffs
go
create table Staffs
(
  --SfId int not null primary key identity(3000,1),--员工ID、考勤号、工号(自增长)
  SfId int not null,--员工ID、考勤号、工号
  SfCardNo varchar(21) not null default'待分配',--考勤卡号
  SfDepartment varchar(21) not null default'待分配',--部门名
  SfGroup varchar(21) not null default'待分配',--组别
  SfJob varchar(28) not null default'待分配',--职位
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
  SfShifts varchar(30)--轮班班次
  )
go

--创建OriginalLog表 --考勤原始记录
use AttReport
go
if exists(select*from sysobjects where name='OriginalLog')
drop table OriginalLog
go
create table OriginalLog
(
  ClockId int not null,--考勤号
  MachineId int not null,--机器号  
  VerifyMode int not null,--验证方式：0为密码验证，1为指纹验证，2为卡验证
  InOutMode int not null,--考勤状态
  ClockRecord datetime not null,--打卡时间
)
go

--创建DailyReport表 --考勤日报表
use AttReport
go
if exists(select*from sysobjects where name='DayReport')
drop table DayReport
go
create table DayReport
(
  AtDate datetime,--考勤日期
  SfId int not null,--员工ID、考勤号、工号
  SfName varchar(21) not null,--员工姓名
  SfGroup varchar(21) not null,--员工组别
  ClassesName varchar(21) not null,--班次名称
  WorkTime1 varchar(21),--上班打卡时间1
  OffDutyTime1 varchar(21),--下班打卡时间1
  WorkTime2 varchar(21),--上班打卡时间2
  OffDutyTime2 varchar(21),--下班打卡时间2
  WorkTime3 varchar(21),--上班打卡时间3
  OffDutyTime3 varchar(21),--下班打卡时间3
  AtDay decimal(2,1),--考勤天数
  ----------------------------------
  AtState int,--考勤状态
  AtSign int,--考勤标记
  AtLateM int,--迟到分钟
  AtLateNumber int,--迟到次数
  AtLeaveEarlyM int,--早退分钟
  AtLeaveEarlyNumber int,--早退次数
  AtleaveH decimal(2,1),--事假小时数
  AtleaveNumber int,--事假次数（事假）
  AtSickLeave decimal(2,1),--病假小时数
  AtSickLeaveNumber int,--病假次数
  AtAbsenteeism decimal(2,1),--旷工天数
  AtAbsenteeismNumber int,--旷工次数
  AtRestH decimal(2,1),--放假休息小时数
  AtHoliday decimal(2,1),--节假日，按天计

)
go
