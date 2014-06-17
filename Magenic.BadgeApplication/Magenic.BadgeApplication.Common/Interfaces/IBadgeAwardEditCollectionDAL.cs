﻿using Magenic.BadgeApplication.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Magenic.BadgeApplication.Common.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBadgeAwardEditCollectionDAL
    {
        /// <summary>
        /// Gets all badge awards for user asynchronous.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns></returns>
        Task<IEnumerable<BadgeAwardEditDTO>> GetAllBadgeAwardsForUserAsync(string userName);
    }
}