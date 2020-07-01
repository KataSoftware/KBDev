// Angular Imports
import { Component, OnInit, Injector, TemplateRef, ViewChild } from '@angular/core';

// SFSCommon Imports
import { DataService, ListPage } from 'sfscommon';

@Component({
  selector: 'app-list',
  templateUrl: 'list.page.html',
  styleUrls: ['list.page.scss']
})
export class MyListPage extends ListPage implements OnInit {

  @ViewChild('editTmpl') editTmpl: TemplateRef<any>;

  constructor(public injector: Injector, public dataService: DataService) {

    super(injector, dataService);

    // Se recupera la entidad
    this.entitySetName = this.route.snapshot.paramMap.get('entitySetName');

    // Se establece un título
    this.title = this.entitySetName;

    // Se inicializan
    // this.data = [];
    // this.tableColumns = [];
    // this.displayedColumns = [];
    this.pagination = {
      total: 0,
      pageIndex: 1,
      pageSize: 10,
      previousPageIndex: 0
    };
  }

  async ngOnInit() {

    this.data = [
      {
        col1: 'HolaC11',
        col2: 'HolaC12',
        col3: 'HolaC13',
        col4: 'HolaC14',
      },
      {
        col1: 'HolaC21',
        col2: 'HolaC22',
        col3: 'HolaC23',
        col4: 'HolaC24',
      },
      {
        col1: 'HolaC31',
        col2: 'HolaC32',
        col3: 'HolaC33',
        col4: 'HolaC34',
      }
    ];

    this.tableColumns = [
      {
        name: 'COL 1',
        prop: 'col1',
        cellTemplate: this.editTmpl
      },
      {
        name: 'COL 2',
        prop: 'col2'
      },
      {
        name: 'COL 3',
        prop: 'col3'
      },
      {
        name: 'COL 4',
        prop: 'col4'
      }
    ];

    this.displayedColumns =  [
      'col1',
      'col2',
      'col3',
      'col4',
    ];
  }

}
