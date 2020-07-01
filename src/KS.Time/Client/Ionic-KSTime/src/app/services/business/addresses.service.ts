// Angular Imports
import { Injectable } from '@angular/core';

// SFSCommon Imports
import { GeolocationService } from 'sfscommon';

@Injectable({ providedIn: 'root' })
export class addressesService {

  constructor(public geo: GeolocationService) { }

  async getGeoData(countryCode, zipCode) {

    const geoData = await this.geo.getGeoDataByPostalCode(countryCode, zipCode);

    return geoData;
  }

  recoverStatesFromCountry(country) {

    // Se valida la existencia de datos.
    if (country && country.secGeoStates) {

      // Se recuperan las Estados.
      return country.secGeoStates;
    }

    return null;
  }

  recoverCitiesFromStates(statesList, guidStateSelected) {

    if (statesList == null) { return; }

    // Se iteran los Estados.
    for (const state of statesList) {

      // Si la Estado es igual al Seleccionado.
      if (state.GuidState == guidStateSelected) {

        // Se retorna la lista de Ciudades.
        return state.secGeoCities;
      }
    }

    if (guidStateSelected == '') {

      return null;

    } else if (!guidStateSelected && statesList[0]) { // No existe Ciudad seleccionada.

      // Se toma por Default la primera.
      return statesList[0].secGeoCities;
    }

    return null;
  }

  recoverSubCitiesFromCities(citiesList, guidCitySelected) {

    if (citiesList == null) { return; }

    // Se iteran las Ciudades.
    for (const city of citiesList) {

      // Si la Ciudad actual es igual a la seleccionada.
      if (city.GuidCity == guidCitySelected) {

        // Se asigna el listado.
        return city.SubCities;
      }
    }

    if (guidCitySelected == '') {

      return null;

    } if (!guidCitySelected && citiesList[0]) { // No existe SubCiudad seleccionada.

      // Se toma por Default la primera.
      return citiesList[0].SubCities;
    }

    return null;
  }
}
