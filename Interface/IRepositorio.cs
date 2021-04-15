using System.Collections.Generic;

namespace Dio.series.Interface
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T RetornaPorId(int id);

         void Insere(T entidade);

         void Exclui(int id);

         void Atualizq(int id, T entidade);
         
         int ProximoId();
    }
}