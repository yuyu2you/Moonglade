﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Moonglade.Data.Entities;
using Moonglade.Data.Infrastructure;

namespace Moonglade.Data.Spec
{
    public sealed class CommentOfPostSpec : BaseSpecification<Comment>
    {
        //public CommentOfPostSpec(Expression<Func<Comment, bool>> criteria) : base(criteria)
        //{
        //}

        public CommentOfPostSpec(Guid postId) :base(c => c.PostId == postId &&
                                                   c.IsApproved != null &&
                                                   c.IsApproved.Value)
        {
            AddInclude(c => c.CommentReply);
        }
    }
}
