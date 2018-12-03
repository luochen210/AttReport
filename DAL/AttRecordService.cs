using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;
using System.Diagnostics;

namespace DAL
{
    public class AttRecordService
    {

        /// <summary>
        /// 通用查询类
        /// </summary>
        /// <param name="SQLtableName">SQL数据表名</param>
        /// <returns>结果数据集</returns>
        public DataSet GetSQLTableDataSet(string SQLtableName)
        {
            string sql = "select * from '{0}'";
            sql = string.Format(sql, SQLtableName);

            return SQLHelper.GetDataSet(sql);
        }

        #region 普通方式写入数据
        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="MachineId">机器号码</param>
        /// <param name="ClockId">考勤ID</param>
        /// <param name="VerifyMode">验证方式</param>
        /// <param name="InOutMode">考勤状态</param>
        /// <param name="ClockRecord">打卡时间</param>
        /// <returns>打卡时间</returns>
        public string AddAttrecord(int MachineId, int ClockId, int VerifyMode, int InOutMode, string ClockRecord)
        {
            string sql = "insert into  OriginalLog (MachineId,ClockId,VerifyMode,InOutMode,ClockRecord) values ({0},{1},{2},{3},'{4}')";
            sql = string.Format(sql, MachineId, ClockId, VerifyMode, InOutMode, ClockRecord);

            SQLHelper.Update(sql);

            return sql;
        }

        #endregion


        /// <summary>
        /// 获取月记录
        /// </summary>
        /// <param name="StartDate">起始时间</param>
        /// <param name="EndDate">结束时间</param>
        /// <returns>月记录数据集</returns>
        public DataSet GetMonthlyReportDataSet(string StartDate, string EndDate)
        {
            string sql = "select * from OriginalLog ";
            sql += " where CONVERT(varchar(100), ClockRecord, 111) >= '{0}' and CONVERT(varchar(100), ClockRecord, 111) <= '{1}'";
            sql = string.Format(sql, StartDate, EndDate);

            return SQLHelper.GetDataSet(sql);
        }


        /// <summary>
        /// 获取员工姓名
        /// </summary>
        /// <param name="AttId">考勤Id</param>
        /// <returns>员工姓名</returns>
        public int GetStaffList(string AttId)
        {
            string sql = "select SfName from Staffs where SfId={0}";
            sql = string.Format(sql, AttId);

            return Convert.ToInt32(SQLHelper.GetSingleResult(sql));
        }

        /// <summary>
        /// 获取员工班次
        /// </summary>
        /// <param name="StaffId">考勤Id</param>
        /// <returns>员工班次名称</returns>
        public string GetShifts(string StaffId)
        {
            string sql = "select SfShifts from Staffs where SfId={0}";
            sql = string.Format(sql, StaffId);

            var result = SQLHelper.GetSingleResult(sql);

            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取时段名称
        /// </summary>
        /// <param name="ClassesName">班次名称</param>
        /// <returns>时段名称List</returns>
        public List<ClassesTimes> GetTimesName(string ClassesName)
        {
            string sql = "select * from ClassesTimes where ClassesName='{0}'";
            sql = string.Format(sql, ClassesName);

            SqlDataReader objReader = SQLHelper.GetReader(sql);

            List<ClassesTimes> list = new List<ClassesTimes>();
            while (objReader.Read())
            {
                list.Add(new ClassesTimes()
                {
                    ClassesName=objReader["ClassesName"].ToString(),
                    TimesName1 = objReader["TimesName1"].ToString(),
                    TimesName2 = objReader["TimesName2"].ToString(),
                    TimesName3=objReader["TimesName3"].ToString()
                });
            }
            return list;
        }

        
        /// <summary>
        /// 获取班次时段List
        /// </summary>
        /// <param name="TimesName">时段名称</param>
        /// <returns>时段集合</returns>
        public List<TimesManage> GetTimes(string TimesName)
        {
            string sql = "select * from TimesManage where TimesName='{0}'";
            sql = string.Format(sql, TimesName);

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<TimesManage> list = new List<TimesManage>();
            while (objReader.Read())
            {
                list.Add(new TimesManage()
                {
                    TimesName = objReader["TimesName"].ToString(),
                    WorkTime = objReader["WorkTime"].ToString(),
                    OffDutyTime=objReader["OffDutyTime"].ToString(),
                    StartCheckIn=objReader["StartCheckIn"].ToString(),
                    EndCheckIn = objReader["EndCheckIn"].ToString(),
                    StartSignBack = objReader["StartSignBack"].ToString(),
                    EndSignBack = objReader["EndSignBack"].ToString(),
                    LateTime = Convert.ToInt32(objReader["LateTime"]),
                    LeftEarly = Convert.ToInt32(objReader["LeftEarly"])

                });
            }
            return list;
        }




        //#region 实现代码

        ///// <summary>
        ///// 获取考勤列表
        ///// </summary>
        ///// <param name="dto"></param>
        ///// <param name="Page"></param>
        ///// <param name="PageSize"></param>
        ///// <returns></returns>
        //public ResultEntity<List<AttendCountDTO>> QueryAttendList(SearchAttendCountDTO dto, int Page, int PageSize)
        //{
        //    #region 获取当前年月日
        //    var FirstDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM") + " -01");         //当前月第一天
        //    var NowDate = DateTime.Now;
        //    #endregion

        //    var lists = new List<AttendCountDTO>();
        //    DepartRepository departRepository = new DepartRepository();
        //    AttendCountRepository attendCountRepository = new AttendCountRepository();
        //    HolidayRepository holidayRepository = new HolidayRepository();
        //    DPEAssRepository dpeAssRepository = new DPEAssRepository();
        //    PostRepository postRepository = new PostRepository();
        //    AttendEditorRepository attendEditorRepository = new AttendEditorRepository();
        //    AttendancesRepository attendRepository = new AttendancesRepository();
        //    GetWorkDays workDays = new GetWorkDays();
        //    var allEmployees = attendCountRepository.QueryAllEmployee(dto);         //所有员工
        //    var allEmployeeIds = allEmployees.Select(f => f.Id).ToList();           //所有员工Id
        //    var allAttendEntities = attendRepository.GetAllAttendancesById(allEmployeeIds);     //所有员工的所有考勤
        //    var allOffWorkEntities = attendRepository.GetAllOffWork(allEmployeeIds);     //所有员工的所有考勤
        //    var allDPEEntities = dpeAssRepository.GetAllDPEAssById(allEmployeeIds);            //获得所有员工关联表
        //    var allDPEIds = allDPEEntities.Select(f => f.PostId).ToList();                //获得所有员工关联表的岗位Id
        //    var allPostEntities = postRepository.GetAllPostById(allDPEIds);               //获得所有员工的岗位信息
        //    var allDepartIds = allPostEntities.Select(f => f.DepartmentId).ToList();         //获得所有员工岗位的部门Id
        //    var allDepartEntities = departRepository.QueryAllDepart(allDepartIds);          //获得所有员工的部门信息
        //    var allAttendConfigEntities = attendEditorRepository.GetAllAttendancesConfigById(allDepartIds);        //获得所有员工的考勤配置信息



        //    if (allEmployees.Count() > 0)
        //    {
        //        foreach (var Employee in allEmployees)
        //        {
        //            AttendCountDTO attendCountDTO = new AttendCountDTO();


        //            #region    获得部门名称,和该部门的上班下班时间
        //            string[] WorkDayNums = null;
        //            int NoWorkDayNum = 0;
        //            var workStartTime = new DateTime(2007, 1, 1, 9, 00, 00);
        //            var workEndTime = new DateTime(2007, 1, 1, 18, 00, 00);
        //            var dpeass = allDPEEntities.Where(f => f.EmployeeId == Employee.Id).FirstOrDefault();
        //            if (dpeass != null)
        //            {
        //                var post = allPostEntities.Where(f => f.Id == dpeass.PostId).FirstOrDefault();
        //                if (post != null)
        //                {
        //                    if (string.IsNullOrEmpty(dto.Position) || post.Name == dto.Position)
        //                    {
        //                        attendCountDTO.Position = post.Name;
        //                        var department = allDepartEntities.Where(f => f.Id == post.DepartmentId).FirstOrDefault();                    //获取员工所属的部门
        //                        if (department != null)
        //                        {
        //                            if (string.IsNullOrEmpty(dto.DepartmentName) || department.Name.Contains(dto.DepartmentName))
        //                            {
        //                                attendCountDTO.DepartmentName = department.Name;
        //                                attendCountDTO.DepartmentId = department.Id;
        //                                var attendConfig = allAttendConfigEntities.Where(f => f.DepartmentId == department.Id).FirstOrDefault();
        //                                if (attendConfig != null)
        //                                {
        //                                    workStartTime = DateTime.Parse(attendConfig.StartTime);             //该部门的上班时间和下班时间
        //                                    workEndTime = DateTime.Parse(attendConfig.EndTime);

        //                                    #region 工作日
        //                                    string workDay = attendConfig.WorkDays;
        //                                    string WorkDay = workDay.Substring(0, workDay.Length - 1);
        //                                    WorkDayNums = WorkDay.Split(',');
        //                                    NoWorkDayNum = 7 - WorkDayNums.Count();                //该员工所在部门的一周非工作天数
        //                                    #endregion
        //                                }
        //                            }
        //                            else
        //                            {
        //                                continue;
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        continue;
        //                    }
        //                }
        //            }
        //            #endregion 

        //            #region 根据当天时刻修正次数
        //            int Modify = 0;
        //            var time = DateTime.Parse(NowDate.ToString("HH:mm:ss"));
        //            var startTime = DateTime.Parse(workStartTime.ToString("HH:mm:ss"));
        //            var endTime = DateTime.Parse(workEndTime.ToString("HH:mm:ss"));
        //            if (time <= startTime)                                   //当前时间在第二天中午之前，为为一天，中午12点后计算结果为2天，则需要对考勤次数进行修正。
        //            {
        //                Modify = 0;
        //            }
        //            else if (time >= startTime && time <= DateTime.Parse("12:00:00"))
        //            {
        //                Modify = -1;
        //            }
        //            else if (time >= DateTime.Parse("12:00:00") && time < endTime)
        //            {
        //                Modify = 1;
        //            }
        //            else if (time >= endTime)
        //            {
        //                Modify = 0;
        //            }
        //            #endregion

        //            DateTime firstDate = FirstDate;
        //            var applyTime = Employee.EntryDate;                                   //员工入职时间
        //            if (applyTime.HasValue && applyTime >= FirstDate)           //如果员工是这个月内刚入职的，取入职时间
        //            {
        //                firstDate = DateTime.Parse(applyTime.Value.ToString("yyyy-MM-dd"));
        //            }
        //            var attendEntities = allAttendEntities.Where(f => f.CreaterId == Employee.Id && (f.CreateDate >= firstDate && f.CreateDate <= NowDate)).OrderBy(f => f.CreateDate).ToList();
        //            var attendCounts = attendEntities.Count();                //当前月实际打卡的次数

        //            #region  //实际打卡的天数
        //            List<string> list = new List<string>();
        //            foreach (var attend in attendEntities)
        //            {
        //                var attendDay = attend.CreateDate.ToLongDateString();
        //                list.Add(attendDay);
        //            }
        //            attendCountDTO.ActualDays = list.Distinct().Count();      //实际打卡的天数
        //            #endregion      

        //            #region  应打卡的天数
        //            int days = 0;
        //            int AllDay = 0;
        //            var nowTime = DateTime.Now;

        //            if (applyTime != null)
        //            {
        //                attendCountDTO.OutHiredate = applyTime == null ? "" : DateTime.Parse(applyTime.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
        //                attendCountDTO.Hiredate = applyTime;
        //                if (NoWorkDayNum == 0)
        //                {
        //                    AllDay = workDays.GetNoHolidayWorkDay(firstDate, NowDate);
        //                }
        //                else
        //                {
        //                    AllDay = workDays.GetDate(firstDate, NowDate, WorkDayNums);                     //获取到（设置的指定的工作日）所有天数
        //                    //AllDay = workDays.GetWorkDay(firstDate, NowDate, NoWorkDayNum);                       //获取工作天数（已去除设置的非工作日）
        //                }

        //                var holidayDays = holidayRepository.GetHolidayByTime(firstDate, nowTime);    //当月所有的节假日
        //                if (holidayDays.Count() > 0)
        //                {
        //                    holidayDays.ForEach(f =>
        //                    {
        //                        TimeSpan ts = f.EndTime - f.BeginTime;
        //                        days += ts.Days;
        //                    });
        //                }
        //                #region  请假的天数
        //                int offWorkDay = 0;
        //                DateTime? validEndTime = null;
        //                var OffWorkEntitys = allOffWorkEntities.Where(f => f.CreaterId == Employee.Id
        //                        && f.StartTime >= firstDate && f.StartTime <= nowTime).ToList();
        //                if (OffWorkEntitys.Count() > 0)
        //                {
        //                    foreach (var item in OffWorkEntitys)
        //                    {
        //                        if (item.EndTime > nowTime)           //如果请假的结束时间大于当前考勤的统计时间，取当前时间，
        //                        {
        //                            validEndTime = nowTime;
        //                        }
        //                        else
        //                        {
        //                            validEndTime = item.EndTime;        //如果请假的结束时间小于等于当前考勤的统计时间，取请假的结束时间，
        //                        }
        //                        TimeSpan? t1 = validEndTime - item.StartTime;
        //                        offWorkDay += t1.Value.Days;
        //                    }
        //                }
        //                #endregion

        //                attendCountDTO.ShouldDays = AllDay - days - offWorkDay;       //应打卡的天数(工作日天数-法定节假日天数 - 请假天数)
        //                #endregion
        //                attendCountDTO.AbsenteeismDays = attendCountDTO.ShouldDays - attendCountDTO.ActualDays;       //应打天数-实打天数
        //                attendCountDTO.ShouldAttendCounts = (attendCountDTO.ShouldDays * 2) - Modify;                       //应打考勤的次数
        //                attendCountDTO.NoAttendCounts = attendCountDTO.ShouldAttendCounts - attendCounts;        //未打卡的次数（应打卡的次数-实际打卡的次数）
        //            }

        //            #region      判断迟到还是早退,以及次数
        //            //var entitys = GetResignInfo(Employee.Id);        //所有考勤次数
        //            int lateCount = 0;
        //            int earlyLeaveCount = 0;
        //            int AllCounts = attendEntities.Count();
        //            for (int i = 0; i < AllCounts; i++)
        //            {
        //                if (i == 0 && i + 1 == AllCounts)    //只打卡了一次  （第一种情况）   只判断是否迟到
        //                {
        //                    if (attendEntities[i].CreateDate.TimeOfDay.TotalHours >= workStartTime.TimeOfDay.TotalHours) lateCount += 1;
        //                }
        //                if (i == 0 && i + 1 < AllCounts)     //打卡多次，这是第一次    （第二种情况）
        //                {
        //                    if (attendEntities[i].CreateDate.ToLongDateString() == attendEntities[i + 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours >= workStartTime.TimeOfDay.TotalHours) lateCount += 1;
        //                    }
        //                    else if (attendEntities[i].CreateDate.ToLongDateString() != attendEntities[i + 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours >= workStartTime.TimeOfDay.TotalHours) lateCount += 1;
        //                    }
        //                }
        //                if (i > 0 && i + 1 < AllCounts)      //打卡多次，既不是第一次，也不是最后一次     （第三种情况）
        //                {
        //                    if (attendEntities[i].CreateDate.ToLongDateString() == attendEntities[i - 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours <= workEndTime.TimeOfDay.TotalHours) earlyLeaveCount += 1;        //打卡了两次，这是下午一次
        //                    }
        //                    if (attendEntities[i].CreateDate.ToLongDateString() == attendEntities[i + 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours > workStartTime.TimeOfDay.TotalHours) lateCount += 1;              //打卡了两次，这是上午一次
        //                    }
        //                    if (attendEntities[i].CreateDate.ToLongDateString() != attendEntities[i - 1].CreateDate.ToLongDateString() && attendEntities[i].CreateDate.ToLongDateString() != attendEntities[i + 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours >= workStartTime.TimeOfDay.TotalHours) lateCount += 1;                      //只打卡一次，大于上午上班时间，即迟到
        //                    }
        //                }
        //                if (i > 0 && i + 1 == AllCounts)     //打卡多次，这是是最后一次     （第四种情况）
        //                {
        //                    if (attendEntities[i].CreateDate.ToLongDateString() == attendEntities[i - 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours <= workEndTime.TimeOfDay.TotalHours) earlyLeaveCount += 1;        //打卡了两次，这是下午一次
        //                    }
        //                    if (attendEntities[i].CreateDate.ToLongDateString() != attendEntities[i - 1].CreateDate.ToLongDateString())
        //                    {
        //                        if (attendEntities[i].CreateDate.TimeOfDay.TotalHours >= workStartTime.TimeOfDay.TotalHours) lateCount += 1;
        //                    }
        //                }
        //            }

        //            attendCountDTO.LateCounts = lateCount;
        //            attendCountDTO.EarlyLeaveCounts = earlyLeaveCount;
        //            attendCountDTO.Id = Employee.Id;
        //            attendCountDTO.Name = Employee.Name;
        //            attendCountDTO.PhoneNumber = Employee.Phone;

        //            lists.Add(attendCountDTO);
        //            #endregion
        //        }
        //    }
        //    DateTime? EndTime = null;
        //    if (dto.EndTime.HasValue)
        //    {
        //        EndTime = dto.EndTime.Value.AddDays(1);
        //    }
        //    var filterEmployees = lists.Where(f => (string.IsNullOrEmpty(dto.DepartmentName) || (!string.IsNullOrEmpty(f.DepartmentName) && f.DepartmentName.Contains(dto.DepartmentName)))
        //                    && (string.IsNullOrEmpty(dto.Position) || f.Position == dto.Position)
        //                    && (!dto.StartTime.HasValue || f.Hiredate >= dto.StartTime)
        //                    && (!EndTime.HasValue || f.Hiredate <= EndTime)).ToList();
        //    var filterEmployee = filterEmployees.OrderBy(f => f.Hiredate).Skip((Page - 1) * PageSize).ToList();
        //    var resultEntity = GetResultEntity(filterEmployee);
        //    resultEntity.Count = filterEmployees.Count();
        //    return resultEntity;
        //}


        ///// <summary>
        ///// 获取考勤详情
        ///// </summary>
        ///// <param name="param"></param>
        ///// <returns></returns>
        //public ResultEntity<List<AttendCountDetailDTO>> QueryAttendDetailList(AttendDetailDTO param)
        //{
        //    var lists = new List<AttendCountDetailDTO>();
        //    AttendEditorRepository attendEditorRepository = new AttendEditorRepository();
        //    AttendancesRepository attendRepositry = new AttendancesRepository();
        //    AttendancesConfig attendConfig = new AttendancesConfig();
        //    var attendEditor = attendEditorRepository.GetAttendancesConfigById(param.DepartmentId);       //设置的规定考勤
        //    if (attendEditor == null)
        //    {
        //        attendConfig.StartTime = "09:00:00";
        //        attendConfig.EndTime = "18:00:00";
        //    }
        //    else
        //    {
        //        attendConfig.StartTime = attendEditor.StartTime;
        //        attendConfig.EndTime = attendEditor.EndTime;
        //    }

        //    var attends = attendRepositry.GetAttendancesById(param.Id);                      //实际员工打卡信息
        //    var DetailCount = attends.Count();                         //考勤次数
        //    for (int i = 0; i < attends.Count(); i++)
        //    {
        //        AttendCountDetailDTO dto = new AttendCountDetailDTO();
        //        dto.AttendDate = attends[i].CreateDate.ToString("yyyy-MM-dd HH:mm:ss");
        //        dto.ActualAttendTime = attends[i].CreateDate.ToLongTimeString().ToString();
        //        if (DetailCount == 1)                                   //只打卡了一次
        //        {
        //            if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //            {
        //                dto.AttendType = "上午考勤";
        //            }
        //            else
        //            {
        //                dto.AttendType = "下午考勤";
        //            }
        //            if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.StartTime).TimeOfDay.TotalHours)
        //            {
        //                dto.IsLate = false;
        //            }
        //            else
        //            {
        //                dto.IsLate = true;
        //            }
        //        }

        //        if (i == 0 && i + 1 < DetailCount)     //打卡多次，这是第一次    （第二种情况）
        //        {
        //            if (attends[i].CreateDate.ToLongDateString() == attends[i + 1].CreateDate.ToLongDateString())
        //            {
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.StartTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsLate = false;
        //                }
        //                else
        //                {
        //                    dto.IsLate = true;
        //                }
        //            }

        //            else if (attends[i].CreateDate.ToLongDateString() != attends[i + 1].CreateDate.ToLongDateString())
        //            {
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.StartTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsLate = false;
        //                }
        //                else
        //                {
        //                    dto.IsLate = true;
        //                }
        //            }
        //        }

        //        if (i > 0 && i + 1 < DetailCount)      //打卡多次，既不是第一次，也不是最后一次     （第三种情况）
        //        {
        //            if (attends[i].CreateDate.ToLongDateString() == attends[i - 1].CreateDate.ToLongDateString())            //打卡了两次，这是下午一次
        //            {
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.EndTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsRarlyLeave = true;
        //                }
        //                else
        //                {
        //                    dto.IsRarlyLeave = false;

        //                }
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //            }
        //            if (attends[i].CreateDate.ToLongDateString() == attends[i + 1].CreateDate.ToLongDateString())                           //打卡了两次，这是上午一次
        //            {
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.StartTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsLate = false;
        //                }
        //                else
        //                {
        //                    dto.IsLate = true;
        //                }
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //            }
        //            if (attends[i].CreateDate.ToLongDateString() != attends[i - 1].CreateDate.ToLongDateString() && attends[i].CreateDate.ToLongDateString() != attends[i + 1].CreateDate.ToLongDateString())         //一天只打卡了一次，
        //            {
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.StartTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsLate = false;
        //                }
        //                else
        //                {
        //                    dto.IsLate = true;
        //                }
        //            }
        //        }

        //        if (i > 0 && i + 1 == DetailCount)     //打卡多次，这是是最后一次     （第四种情况）
        //        {
        //            if (attends[i].CreateDate.ToLongDateString() == attends[i - 1].CreateDate.ToLongDateString())               //打卡了两次，这是下午一次
        //            {
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.EndTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsRarlyLeave = true;
        //                }
        //                else
        //                {
        //                    dto.IsRarlyLeave = false;

        //                }
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //            }
        //            if (attends[i].CreateDate.ToLongDateString() != attends[i - 1].CreateDate.ToLongDateString())                 //只打卡了一次
        //            {
        //                if (int.Parse(attends[i].CreateDate.ToString("HH")) >= 1 && int.Parse(attends[i].CreateDate.ToString("HH")) <= 12)
        //                {
        //                    dto.AttendType = "上午考勤";
        //                }
        //                else
        //                {
        //                    dto.AttendType = "下午考勤";
        //                }
        //                if (attends[i].CreateDate.TimeOfDay.TotalHours <= DateTime.Parse(attendConfig.StartTime).TimeOfDay.TotalHours)
        //                {
        //                    dto.IsLate = false;
        //                }
        //                else
        //                {
        //                    dto.IsLate = true;

        //                }
        //            }
        //        }
        //        dto.Address = attends[i].Addr;
        //        dto.Picture = attends[i].GPS;
        //        dto.AttendRemark = attends[i].Description;
        //        lists.Add(dto);
        //    }
        //    var resultEntity = GetResultEntity(lists);
        //    resultEntity.Count = lists.Count();
        //    return resultEntity;
        //}


        //#endregion








    }
}
