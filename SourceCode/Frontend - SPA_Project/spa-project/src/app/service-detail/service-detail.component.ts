import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';
@Component({
	selector: 'app-service-detail',
	templateUrl: './service-detail.component.html',
	styleUrls: ['./service-detail.component.scss']
})
export class ServiceDetailComponent implements OnInit {

	disableList1: boolean;
	disableList2: boolean;
	disableList3: boolean;
	disableList4: boolean;
	disableList5: boolean;
	disableList6: boolean;
	disableList7: boolean;
	disableList8: boolean;
	disableList9: boolean;
	disableList10: boolean;
	listServices: any;

	public listId;
	constructor(private route: ActivatedRoute,
		private http: HttpClient) { }

	ngOnInit() {
		this.http.get('http://localhost:5000/api/services/list').subscribe(
			data => {
				this.listServices = data;
			})

		let id = parseInt(this.route.snapshot.paramMap.get('id'));
		this.listId = id;
		this.disableList1 = true;
		this.disableList2 = true;
		this.disableList3 = true;
		this.disableList4 = true;
		this.disableList5 = true;
		this.disableList6 = true;
		this.disableList7 = true;
		this.disableList8 = true;
		this.disableList9 = true;
		this.disableList10 = true;

		this.disableAllList();
	}

	disableAllList() {
		if (this.listId == 1) { this.disableList1 = false };
		if (this.listId == 2) { this.disableList2 = false };
		if (this.listId == 3) { this.disableList3 = false };
		if (this.listId == 4) { this.disableList4 = false };
		if (this.listId == 5) { this.disableList5 = false };
		if (this.listId == 6) { this.disableList6 = false };
		if (this.listId == 7) { this.disableList7 = false };
		if (this.listId == 8) { this.disableList8 = false };
		if (this.listId == 9) { this.disableList9 = false };
		if (this.listId == 10) { this.disableList10 = false };
	}

}
