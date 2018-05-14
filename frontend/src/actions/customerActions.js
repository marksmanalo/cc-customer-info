import * as types from './actionTypes';
import customerApi from '../api/mockCustomerApi';

export function loadCustomersSuccess(customers) {
  return { type: types.LOAD_CUSTOMERS_SUCCESS, customers };
}

export function loadCustomers() {
  return function (dispatch) {
    return customerApi.getAllCustomers().then(
      customers => {
        dispatch(loadCustomersSuccess(customers));
      }
    ).catch(error => {
      throw(error);
    });
  };
}