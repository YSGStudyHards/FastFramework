using DotNetGuideBlogBLL.Articles;
using DotNetGuideBlogModel.Common;
using DotNetGuideBlogModel.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DotNetGuideBlogWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ArticleController(IArticleService articleService) : ControllerBase
{
    [HttpGet]
    public async Task<ApiResult<List<ArticleDto>>> GetListAsync()
    {
        var result = await articleService.GetListAsync();
        return ApiResult<List<ArticleDto>>.Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResult<ArticleDto>> GetByIdAsync(int id)
    {
        var result = await articleService.GetByIdAsync(id);
        return result is null
            ? ApiResult<ArticleDto>.Fail("文章不存在")
            : ApiResult<ArticleDto>.Ok(result);
    }

    [HttpPost]
    public async Task<ApiResult<ArticleDto>> CreateAsync([FromBody] CreateArticleRequest request)
    {
        var result = await articleService.AddAsync(request);
        return result is null
            ? ApiResult<ArticleDto>.Fail("标题不能为空")
            : ApiResult<ArticleDto>.Ok(result, "创建成功");
    }

    [HttpPut("{id:int}")]
    public async Task<ApiResult<bool>> UpdateAsync(int id, [FromBody] UpdateArticleRequest request)
    {
        var success = await articleService.UpdateAsync(id, request);
        return success
            ? ApiResult<bool>.Ok(true, "更新成功")
            : ApiResult<bool>.Fail("更新失败，文章不存在或标题无效");
    }

    [HttpDelete("{id:int}")]
    public async Task<ApiResult<bool>> DeleteAsync(int id)
    {
        var success = await articleService.DeleteAsync(id);
        return success
            ? ApiResult<bool>.Ok(true, "删除成功")
            : ApiResult<bool>.Fail("删除失败，文章不存在");
    }
}
