using System.Collections.Generic;

namespace AirbnbUdc.Repository.Implementation.Mappers
{
    // T1 será el de la capa inferior
    // T2 será el de la capa superior
    public abstract class BaseMapperRepository<T1, T2>
    {
        /// <summary>
        /// Mapea de T1 a T2
        /// </summary>
        /// <param name="input"> entrada de datos T2 </param>
        /// <returns>salida de datos T1</returns>
        public abstract T1 MapperT2toT1(T2 input);

        /// <summary>
        /// Mapea de T1 a T2
        /// </summary>
        /// <param name="input">  </param>
        /// <returns></returns>
        public abstract T2 MapperT1toT2(T1 input);

        /// <summary>
        /// Mapea de T1 a T2 una lista de objetos
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract IEnumerable<T1> MapperT2toT1(IEnumerable<T2> input);
        
        /// <summary>
        /// Mappea de T1 a T2 una lista de objetos
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public abstract IEnumerable<T2> MapperT1toT2(IEnumerable<T1> input);

    }
}
