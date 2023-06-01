import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-itens',
  templateUrl: './itens.component.html',
  styleUrls: ['./itens.component.scss']
})
export class ItensComponent implements OnInit {


  public itens: any =[];
  widthImg: number = 50;
  marginImg: number = 2;
  public itensFiltrados: any = [];
  private _filtroLista:string = '';

  public get filtroLista(): string{
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.itensFiltrados = this.filtroLista ? this.filtrarItens(this.filtroLista) : this.itens;
  }

  filtrarItens(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLowerCase();
    return this.itens.filter(
      (item: any) => item.nome.toLowerCase().indexOf(filtrarPor) !== -1 ||
                        item.descricao.toLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(private http: HttpClient){}

  ngOnInit(): void {  //ao iniciar chama o metodo getEventos/todos os metodos q tiverem listados
    this.getClientes();
  }

  public getClientes():void{
    this.http.get('https://localhost:5001/api/Itens').subscribe(
      response =>{
        this.itens = response;
        this.itensFiltrados = this.itens
      },
      error => console.log(error),

    );

  }

}
