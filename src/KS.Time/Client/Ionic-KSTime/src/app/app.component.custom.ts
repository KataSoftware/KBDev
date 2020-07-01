


export class AppComponentCustom{

    public  getMenu(): Array<any>{

        return [
            {
              title: 'Ordenes',
              url: '/ordenes-list',
              icon: 'list'
            },
            {
              title: 'Validacion-documentacion-list',
              url: '/validacion-documentacion-list',
              icon: 'list'
            },
            {
              title: 'Contratos-list',
              url: '/contratos-list',
              icon: 'list'
            },
            {
              title: 'Solicitud',
              url: '/solicitud',
              icon: 'list'
            }
          ];
    }

}