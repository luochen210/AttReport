    use AttReport  
    go  
    create proc ToOriginalLog
        @ClockId int,  
        @MachineId int,          
        @VerifyMode int,  
        @InOutMode int,  
        @ClockRecord datetime
        
    as  
        insert into OriginalLog(ClockId,MachineId,VerifyMode,InOutMode,ClockRecord)values(@ClockId,@MachineId,@VerifyMode,@InOutMode,@ClockRecord)  
    go  