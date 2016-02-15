namespace AppExemplo.Application.Core
{
    public class ApplicationServiceParam<TDataParam>
    {
        public ApplicationServiceParam(TDataParam dataParam)
        {
            DataParam = dataParam;
        }
        public TDataParam DataParam { get; }
    }
}
