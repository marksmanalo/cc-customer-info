import * as types from './actionTypes';

export function loadCustomers(customers) {
  return { type: types.LOAD_CUSTOMERS };
}