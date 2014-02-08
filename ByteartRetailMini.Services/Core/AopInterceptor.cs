using System;
using Autofac;
using Castle.DynamicProxy;
using NHibernate;
using NHibernate.Context;

namespace ByteartRetailMini.Services.Core
{
    public class AopInterceptor : Castle.DynamicProxy.IInterceptor
    {
        protected event Action<IInvocation> BeforeInvocationProceed;
        protected event Action<IInvocation> AfterInvocationProceed;
        protected event Action<IInvocation, Exception> InvocationProceedThrowException;

        public AopInterceptor()
        {
            BeforeInvocationProceed += OpenNHibernateSession;
            AfterInvocationProceed += DisposeNHibernateSession;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                if (BeforeInvocationProceed != null)
                    BeforeInvocationProceed(invocation);

                invocation.Proceed();

                if (AfterInvocationProceed != null)
                    AfterInvocationProceed(invocation);
            }
            catch (Exception exception)
            {
                if (InvocationProceedThrowException != null)
                {
                    InvocationProceedThrowException(invocation, exception);
                }
            }
        }

        private static void OpenNHibernateSession(IInvocation invocation)
        {
            var sessionFactory = IocHelper.Container.Resolve<ISessionFactory>();
            var session = sessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);
        }

        private static void DisposeNHibernateSession(IInvocation invocation)
        {
            var sessionFactory = IocHelper.Container.Resolve<ISessionFactory>();
            var session = CurrentSessionContext.Unbind(sessionFactory);
            if (session != null)
            {
                session.Flush();
                session.Dispose();
            }
        }
    }
}