import React, {PropTypes} from 'react';
import { Link } from 'react-router';
import {connect} from 'react-redux';
import {bindActionCreators} from 'redux';
import * as customerActions from '../../actions/customerActions';

class CustomerDetailPage extends React.Component {
    componentDidMount() {
        this.props.actions.loadCustomers();
    }

    render() {
        return (
            <div className="jumbotron">
                <h1>Customer Details</h1>
                <p>react</p>
                <Link to="about" className="btn btn-primary btn-lg">Learn more</Link>
            </div>
        );        
    }
}

CustomerDetailPage.propTypes = {
    customers: PropTypes.object,
    actions: PropTypes.object.isRequired
};

function mapStateToProps(state, ownProps) {
    return {
        customers: state.customers
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(customerActions, dispatch)
    };
}

export default connect(mapStateToProps, mapDispatchToProps)(CustomerDetailPage);