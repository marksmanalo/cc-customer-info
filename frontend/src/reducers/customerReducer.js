import * as types from '../actions/actionTypes';

export default function customerReducer(state = {}, action) {
  switch (action.type) {
    case types.LOAD_CUSTOMERS_SUCCESS:
      return action.customers;
    default:
      return state;
  }
}