import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'primeng/api';
import { BlockUIModule } from 'primeng/blockui';
import { ButtonModule } from 'primeng/button';
import { CheckboxModule } from 'primeng/checkbox';
import { InputTextModule } from 'primeng/inputtext';
import { KeyFilterModule } from 'primeng/keyfilter';
import { PaginatorModule } from 'primeng/paginator';
import { PanelModule } from 'primeng/panel';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { TableModule } from 'primeng/table';
import { ExtSharedModule } from './../../shared/modules/ext-shared.module';
import { RoleDetailsComponent } from './roles/role-details/role-details.component';
import { RoleComponent } from './roles/role.component';
import { SystemRoutingModule } from './system-routing.module';
import { UserComponent } from './users/user.component';

@NgModule({
  imports: [
    SystemRoutingModule,
    CommonModule,
    ReactiveFormsModule,
    TableModule,
    ProgressSpinnerModule,
    BlockUIModule,
    PaginatorModule,
    PanelModule,
    CheckboxModule,
    ButtonModule,
    InputTextModule,
    KeyFilterModule,
    SharedModule,
    ExtSharedModule
  ],
  declarations: [UserComponent, RoleComponent, RoleDetailsComponent]
})
export class SystemModule {
}
