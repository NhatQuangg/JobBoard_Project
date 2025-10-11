import { createBrowserRouter } from "react-router-dom";
import App from "../App";
import JobPage from "../Pages/JobPage/JobPage";
import SignupPage from "../Pages/SignUpPage/SignUpPage";
import LoginPage from "../Pages/LoginPage/LoginPage";

export const router = createBrowserRouter([
    {
        path: "/",
        element: <App />,
        children: [],
    },
    {
        path: "/signup",
        element: <SignupPage />,
        children: [],
    },
    {
        path: "/login",
        element: <LoginPage />,
        children: [],
    },
    {
        path: "/jobs",
        element: <JobPage />,
        children: [],
    }
]);
