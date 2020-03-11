using Model;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessageRouter.Routing
{
    public static class EmailRouterFactory
    {

        public static EmailRouterBase GetInstance(Email email)
        {
            switch (email.Type)
            {
                case (int)EmailType.TRANSACTIONAL:
                default:
                    return new TransactionalEmailRouter(email);
                case (int)EmailType.BATCH:
                    return new BatchEmailRouter(email);
            }
        }


    }
}
