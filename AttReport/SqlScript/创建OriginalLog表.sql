--创建OriginalLog表
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

use AttReport
go
if exists(select*from sysobjects where name='pk_ClockRecord')
alter table OriginalLog drop constraint pk_ClockRecord
alter table OriginalLog add constraint pk_ClockRecord primary key(ClockId,ClockRecord)

if exists(select*from sysobjects where name='ClockRecord')
alter table OriginalLog drop constraint uq_ClockRecord
alter table OriginalLog add constraint uq_ClockRecord unique(ClockRecord)