import React from 'react';
import { Route, IndexRoute } from 'react-router';
import App from './components/App';
import CustomerDetailPage from './components/home/CustomerDetailPage';
import AboutPage from './components/about/AboutPage';

export default(
  <Route path="/" component={App}>
    <IndexRoute component={CustomerDetailPage} />
    <Route path="about" component={AboutPage} />
  </Route>
);