﻿using AntSK.Domain.Domain.Dto;
using AntSK.Domain.Utils;
using AntSK.Services.OpenApi;
using Microsoft.AspNetCore.Mvc;

namespace AntSK.Controllers
{

    /// <summary>
    /// 对外接口
    /// </summary>
    [ApiController]
    public class OpenController(IOpenApiService _openApiService) : ControllerBase
    {
        /// <summary>
        /// 对话接口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("api/v1/chat/completions")]
        public async Task chat(OpenAIModel model)
        {
            string sk = HttpContext.Request.Headers["Authorization"].ConvertToString();
            await _openApiService.Chat(model, sk, HttpContext);
        }
    }
}
