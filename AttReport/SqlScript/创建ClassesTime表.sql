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
  ClassesName varchar(21) not null,--班次名称
  TimesName varchar(12) not null,--时间段名称
  WorkTime datetime not null,--上班时间
  OffDutyTime datetime not null,--下班时间
  StartCheckIn datetime not null,--开始签到
  EndCheckIn datetime not null,--结束签到
  StartSignBack datetime not null,--开始签退
  EndSignBack datetime not null,--结束签退
  LateTime int not null,--迟到时间数，计分钟
  LeftEarly int not null,--早退时间数，计分钟
  Monday bit not null,--星期一，1代表true,0代表false
  Tuesday bit not null,--星期二
  Wednesday bit not null,--星期三
  Thursday bit not null,--星期四
  Friday bit not null,--星期五
  Saturday bit not null,--星期六
  Sunday bit not null--星期日
)
go




case "Monday":
week = "星期一";
break;
case "Tuesday":
week = "星期二";
break;
case "Wednesday":
week = "星期三";
break;
case "Thursday":
week = "星期四";
break;
case "Friday":
week = "星期五";
break;
case "Saturday":
week = "星期六";
break;
case "Sunday":
week = "星期日";
