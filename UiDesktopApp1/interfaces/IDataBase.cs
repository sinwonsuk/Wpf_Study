using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiDesktopApp1.Models;

namespace UiDesktopApp1.interfaces
{
    public interface IDataBase<T>
    {
        // 테이블에 대한 모든 데이터 조회 

        List<T>? Get();

        // 테이블에 대해 특정 ID에 해당하는 데이터 조회 
        Task<T?> GetDetail(int id);

        // 테이블에 특정 DATA INSERT

        void Create(T entity);

        // 테이블에 특정 Data Update()

        void Update(T entity);

        // 테이블에 특정 Data Delete()

        void Delete(int id);


    }
}
