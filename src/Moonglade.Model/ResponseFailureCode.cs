﻿namespace Moonglade.Model
{
    public enum ResponseFailureCode
    {
        None = 0,
        GeneralException = 1,
        DataOperationFailed = 2,
        InvalidParameter = 3,
        InvalidModelState = 4,

        // post
        PostNotFound = 100,
        ExtensionNameIsNull = 101,
        ImageNotExistInAzureBlob = 102,
        ImageNotExistInFileSystem = 103,
        ImageDataIsNull = 104,

        // comment
        CommentDisabled = 200,
        CommentNotFound = 201,
        EmailDomainBlocked = 202,

        // tag
        TagNotFound = 300,

        // category
        CategoryNotFound = 400,

        // email
        EmailSendingDisabled = 500,

        // pingback
        PingbackRecordNotFound = 600,

        // remote api
        RemoteApiFailure = 700,

        // friendlink
        FriendLinkNotFound = 800
    }
}