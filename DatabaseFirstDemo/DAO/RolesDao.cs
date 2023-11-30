﻿using DatabaseFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo.DAO
{
	public class RolesDao
	{
		private static RolesDao instance;
		private static readonly object instanceLock = new object();
		public static RolesDao Instance
		{
			get
			{
				lock (instanceLock)
				{
					if (instance == null)
					{
						instance = new RolesDao();
					}
					return instance;
				}
			}
		}

		public List<Role> GetAll()
		{
			List<Role> roles;
			try
			{
				using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
				roles = stock.Roles.ToList();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return roles;
		}

		public Role GetById(int id)
		{
			Role role;
			try
			{
				using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
				role = stock.Roles.SingleOrDefault(r => r.Id == id);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return role;
		}

		public void Insert(Role role)
		{
			try
			{
				using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
				stock.Add(role);
				stock.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Update(Role role)
		{
			try
			{
				using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
				stock.Entry<Role>(role).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
				stock.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Delete(Role role)
		{
			try
			{
				using ProductManagermentBatch177Context stock = new ProductManagermentBatch177Context();
				var rl = stock.Roles.SingleOrDefault(c => c.Id == role.Id);
				stock.Remove(rl);
				stock.SaveChanges();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		//public bool CheckCategoryID(int id)
		//{
		//	try
		//	{
		//		using MyStockDBContext stock = new MyStockDBContext();
		//		var category = stock.Categories.SingleOrDefault(c => c.CategoryID == id);
		//		if (category != null)
		//			return true;
		//		else return false;
		//	}
		//	catch (Exception ex)
		//	{
		//		throw new Exception(ex.Message);
		//	}
		//}



	}
}
