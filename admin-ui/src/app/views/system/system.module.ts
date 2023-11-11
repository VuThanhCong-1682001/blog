import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from 'primeng/api';
import { BadgeModule } from 'primeng/badge';
import { BlockUIModule } from 'primeng/blockui';
import { ButtonModule } from 'primeng/button';
import { CheckboxModule } from 'primeng/checkbox';
import { ImageModule } from 'primeng/image';
import { InputTextModule } from 'primeng/inputtext';
import { KeyFilterModule } from 'primeng/keyfilter';
import { PaginatorModule } from 'primeng/paginator';
import { PanelModule } from 'primeng/panel';
import { PickListModule } from 'primeng/picklist';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { TableModule } from 'primeng/table';
import { ExtSharedModule } from './../../shared/modules/ext-shared.module';
import { PermissionGrantComponent } from './roles/permission-grant/permission-grant.component';
import { RoleDetailsComponent } from './roles/role-details/role-details.component';
import { RoleComponent } from './roles/role.component';
import { SystemRoutingModule } from './system-routing.module';
import { ChangeEmailComponent } from './users/change-email/change-email.component';
import { RoleAssignComponent } from './users/role-assign/role-assign.component';
import { SetPasswordComponent } from './users/set-password/set-password.component';
import { UserDetailsComponent } from './users/user-details/user-details.component';
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
    ExtSharedModule,
    BadgeModule,
    PickListModule,
    ImageModule
  ],
  declarations: [
    UserComponent, 
    RoleComponent, 
    RoleDetailsComponent, 
    PermissionGrantComponent, 
    ChangeEmailComponent, 
    RoleAssignComponent, 
    SetPasswordComponent, 
    UserDetailsComponent
  ]
})
export class SystemModule {
}
