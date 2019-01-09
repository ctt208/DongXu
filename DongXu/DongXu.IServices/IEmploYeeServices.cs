﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
    public interface IEmployeeServices
    {
        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        int AddEmployee(Employee employee);
        /// <summary>
        /// 根据Id删除员工
        /// </summary>
        /// <param name="emploYeeId"></param>
        /// <returns></returns>
        int DeleteEmployee(int employeeId);
        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        List<Employee> GetEmployees();
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        int UpdateEmployee(Employee emploYee);
        /// <summary>
        /// 根据Id查询员工
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
         List<Employee> GetEmployeeById(int employeeId);
    }
}
