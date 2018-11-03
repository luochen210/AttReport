--����OriginalLog��
use AttReport
go
if exists(select*from sysobjects where name='OriginalLog')
drop table OriginalLog
go
create table OriginalLog
(
  ClockId int not null,--���ں�
  MachineId int not null,--������  
  VerifyMode int not null,--��֤��ʽ��0Ϊ������֤��1Ϊָ����֤��2Ϊ����֤
  InOutMode int not null,--����״̬
  ClockRecord datetime not null,--��ʱ��
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