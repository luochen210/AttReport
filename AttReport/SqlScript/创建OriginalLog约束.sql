--创建OriginalLog表约束

use AttReport
go
if exists(select*from sysobjects where name='pk_ClockRecord')
alter table OriginalLog drop constraint pk_ClockRecord
alter table OriginalLog add constraint pk_ClockRecord primary key(ClockId,ClockRecord)

if exists(select*from sysobjects where name='ClockRecord')
alter table OriginalLog drop constraint uq_ClockRecord
alter table OriginalLog add constraint uq_ClockRecord unique(ClockRecord)