﻿using System;
using System.Threading.Tasks;

namespace Airbnb.Lottie
{
    public partial class LOTAnimationView
    {
        /// <summary>
        /// Asynchronously play the animation.
        /// </summary>
        public Task<bool> PlayAsync()
        {
            var tcs = new TaskCompletionSource<bool>();

            this.PlayWithCompletion((bool animationFinished) => tcs.SetResult(animationFinished));

            return tcs.Task;
        }
    }
}
