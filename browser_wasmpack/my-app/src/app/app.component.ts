import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { get_answer, greet, initSync } from 'hello-wasm';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  constructor(private http: HttpClient) {}
  async ngOnInit(): Promise<void> {
    this.http.get('assets/hello_wasm_bg.wasm', { responseType: 'blob' }).subscribe(async (wasmBlob) => {
      const bytes = await wasmBlob.arrayBuffer();
      initSync(bytes);
      greet();
      this.title = 'The answer is ' + get_answer();
     });
  }

  title = 'my-app';
}


