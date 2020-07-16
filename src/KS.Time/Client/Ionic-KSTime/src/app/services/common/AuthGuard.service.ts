import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { UserService } from 'sfscommon';


@Injectable({ providedIn: 'root' })
export class AuthGuardService implements CanActivate {

  constructor(public router: Router, public userService: UserService) {}
  
 async  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    const response = await Promise.all([this.userService.getUserData(), this.userService.getUserToken()]);

    if (response[0] && response[1]) {
      return true;
    } else {
      this.router.navigate(['/login'], {
        queryParams: {
          return: state.url
        }
      });
      return false;
    }
  }
}