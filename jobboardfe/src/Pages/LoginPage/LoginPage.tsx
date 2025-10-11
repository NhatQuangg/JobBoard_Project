import React, { useState } from "react";
import { Link } from "react-router-dom";
import AuthHeader from "../../Components/AuthHeader/AuthHeader";
import GoogleButton from "../../Components/GoogleButton/GoogleButton";
import InputField from "../../Components/InputField/InputField";
import PasswordInput from "../../Components/PasswordInput/PasswordInput";

const LoginPage = () => {
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [showPassword, setShowPassword] = useState(false);

    const handleGoogleLogin = () => console.log("Google login clicked");
    const handleLogin = (e: React.FormEvent) => {
        e.preventDefault();
        console.log("Login:", { email, password });
    };

    return (
        <div className="min-h-screen flex items-center justify-center bg-white px-4">
            <div className="w-full max-w-md space-y-8">
                <AuthHeader title="Welcome back" />

                <form onSubmit={handleLogin} className="space-y-4">
                    {/* Google Login */}
                    <GoogleButton onClick={handleGoogleLogin} />

                    {/* Divider */}
                    <div className="relative">
                        <div className="absolute inset-0 flex items-center">
                            <div className="w-full border-t border-gray-300" />
                        </div>
                        <div className="relative flex justify-center text-sm">
                            <span className="px-2 bg-white text-gray-500">
                                or
                            </span>
                        </div>
                    </div>

                    {/* Email */}
                    <InputField
                        id="email"
                        label="Email Address"
                        type="email"
                        placeholder="jane@example.com"
                        value={email}
                        onChange={(e) => setEmail(e.target.value)}
                        required
                    />

                    {/* Password */}
                    <div>
                        <PasswordInput
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                            showPassword={showPassword}
                            toggleShow={() => setShowPassword((s) => !s)}
                        />

                        {/* Forgot Password link */}
                        <div className="text-right mt-2">
                            <Link
                                to="/forgot-password"
                                className="text-sm text-purple-700 hover:text-purple-800 font-medium"
                            >
                                Forgot password?
                            </Link>
                        </div>
                    </div>

                    {/* Submit Button */}
                    <button
                        type="submit"
                        className="w-full h-12 bg-gradient-to-r from-purple-600 to-purple-700 hover:from-purple-700 hover:to-purple-800 text-white rounded-lg font-medium"
                    >
                        Log in
                    </button>
                </form>

                {/* Sign up link */}
                <p className="text-center text-gray-700 text-sm">
                    Don’t have an account?{" "}
                    <Link
                        to="/signup"
                        className="text-purple-700 hover:text-purple-800 font-medium"
                    >
                        Sign up
                    </Link>
                </p>
            </div>
        </div>
    );
};

export default LoginPage;
