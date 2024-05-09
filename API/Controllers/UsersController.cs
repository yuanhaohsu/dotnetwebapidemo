using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

//  [Authorize] //#44
//  Removed at #34
//  [ApiController]
//  [Route("api/[controller]")] // /api/users
[Authorize]
public class UsersController: BaseApiController
{

    private readonly IUserRepository _userRepository;       //#92
    private readonly IMapper _mapper;                       //#95
    public UsersController(IUserRepository userRepository, IMapper mapper) //# 95
    {
        _mapper = mapper;
        _userRepository = userRepository;
    }

    // [AllowdAnonymous] //#44
    [HttpGet] // Lecture 17 added async
     public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
    {
        var users = await _userRepository.GetMembersAsync();               //#95
       
        return Ok(users);
    }

    //  [Authorize] //#44
    [HttpGet("{username}")] //api/users/2
    public async Task<ActionResult<MemberDto>> GetUser(string username)
    {
         return await _userRepository.GetMemberAsync(username); //#97
    }
}
