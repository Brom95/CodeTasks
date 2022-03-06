using NUnit.Framework;
using System.Collections.Generic;
using Pagination;
namespace PaginationHelper.Tests;

public class Tests
{
    PagnationHelper<char> paginationHelper = new PagnationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);


    [Test]
    [TestCase(0, ExpectedResult = 4)]
    [TestCase(1, ExpectedResult = 2)]
    [TestCase(2, ExpectedResult = -1)]
    public int PageItemCountTest(int pageIndex) => paginationHelper.PageItemCount(pageIndex);

    [Test]
    [TestCase(5, ExpectedResult = 1)]
    [TestCase(2, ExpectedResult = 0)]
    [TestCase(20, ExpectedResult = -1)]
    [TestCase(-10, ExpectedResult = -1)]
    public int PageIndexTest(int itemIndex) => paginationHelper.PageIndex(itemIndex);

    [Test]
    [TestCase(ExpectedResult = 2)]
    public int PageCountTest() => paginationHelper.PageCount;
    [Test]
    [TestCase(ExpectedResult = 6)]
    public int ItemCountTest() => paginationHelper.ItemCount;
}
