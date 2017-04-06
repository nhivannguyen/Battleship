/// <summary>
/// The different AI levels.
/// </summary>
/// 
using System;
using SwinGameSDK;
using System.Collections.Generic;

namespace Battleship
{
    public enum AIOption
    {
        /// <summary>
        /// Easy, total random shooting
        /// </summary>
        Easy,

        /// <summary>
        /// Medium, marks squares around hits
        /// </summary>
        Medium,

        /// <summary>
        /// As medium, but removes shots once it misses
        /// </summary>
        Hard
    }
}