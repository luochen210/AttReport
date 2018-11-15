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
  LateTime varchar(18) not null,--迟到时间数，计分钟
  LeftEarly varchar(18) not null,--早退时间数，计分钟
)
go