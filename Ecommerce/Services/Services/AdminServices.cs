using AutoMapper;
using Services.Common;
using Services.Interfaces;

namespace Services.Services
{
    public class AdminServices : PaggingHelper, IAdminServices
    {
        #region Declare Property

        private readonly IMapper _mapper;

        #endregion

        #region Constructure

        public AdminServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        #endregion

        #region Public Method 
        //public IPagedResults<UserProfileResponse> GetBlogs(UserProfileDto request)
        //{
        //    return null;
        //}

        //public int? SaveBlog(UserProfileModel request)
        //{
        //    return null;
        //}

        //public bool DeleteCategories(int request)
        //{
        //    return true;
        //}

        #endregion

        #region Private Method


        #endregion
    }
}
