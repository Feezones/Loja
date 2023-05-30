import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})
export class ClientesComponent {
  public clientes: any ;

  constructor(private http: HttpClient){}

  ngOnInit(): void {  //ao iniciar chama o metodo getEventos/todos os metodos q tiverem listados
    this.getClientes();
  }

  public getClientes():void{
    this.http.get('https://localhost:5001/api/Clientes').subscribe(
      response => this.clientes = response,
      error => console.log(error),

    );

  }
}
