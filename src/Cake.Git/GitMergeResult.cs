﻿using System;
using LibGit2Sharp;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Cake.Git
{
    /// <summary>
    /// Git repository merge operation result
    /// </summary>
    public sealed class GitMergeResult
    {
        /// <summary>
        /// Merge commit.
        /// </summary>
        public GitCommit Commit { get; }

        /// <summary>
        /// Merge status
        /// </summary>
        public GitMergeStatus Status { get; }

        internal GitMergeResult(MergeResult mergeResult)
        {
            if (mergeResult == null)
            {
                throw new ArgumentNullException(nameof(mergeResult));
            }

            Commit = (mergeResult.Commit==null) ? null : new GitCommit(mergeResult.Commit);
            Status = (GitMergeStatus) mergeResult.Status;
        }
    }
}