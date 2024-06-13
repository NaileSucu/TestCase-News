using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace NewsUI.ViewModels
{
	public class PageViewModel<T>
	{
		public List<T> Items { get; set; }
		public int PageNumber { get; set; }
		public int TotalPages { get; set; }

		public PageViewModel(List<T> items, int count, int pageNumber, int pageSize)
		{
			PageNumber = pageNumber;
			TotalPages = (int)Math.Ceiling(count / (double)pageSize);
			Items = items;
		}

		public bool HasPreviousPage
		{
			get
			{
				return (PageNumber > 1);
			}
		}

		public bool HasNextPage
		{
			get
			{
				return (PageNumber < TotalPages);
			}
		}
	}

}
