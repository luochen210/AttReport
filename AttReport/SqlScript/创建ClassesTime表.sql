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


--创建班次时间表
if exists (select * from sysobjects where name='ClassesTime')
drop table ClassesTime
go
create table ClassesTime
(
  ClassesId int not null,--班次ID
  ClassesName varchar(21) not null,--班次名称
  TimesName varchar(12) not null,--时间段名称
  WorkTime time not null,--上班时间
  OffDutyTime time not null,--下班时间
  StartCheckIn time not null,--开始签到
  EndCheckIn time not null,--结束签到
  StartSignBack time not null,--开始签退
  EndSignBack time not null,--结束签退
  LateTime int not null,--迟到时间数，计分钟
  LeftEarly int not null,--早退时间数，计分钟
  DayNumber int not null,--计天数
  Monday bit not null,--星期一，1代表true,0代表false
  Tuesday bit not null,--星期二
  Wednesday bit not null,--星期三
  Thursday bit not null,--星期四
  Friday bit not null,--星期五
  Saturday bit not null,--星期六
  Sunday bit not null--星期日
)
go