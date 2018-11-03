--创建OriginalLogTemp表
use AttReport
go
if exists(select*from sysobjects where name='OriginalLogTemp')
drop table OriginalLogTemp
go
create table OriginalLogTemp
(
  ClockId int not null,--考勤号
  MachineId int not null,--机器号  
  VerifyMode int not null,--验证方式：0为密码验证，1为指纹验证，2为卡验证
  InOutMode int not null,--考勤状态
  ClockRecord datetime not null,--打卡时间
)
go