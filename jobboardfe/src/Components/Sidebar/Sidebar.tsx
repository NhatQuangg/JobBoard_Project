import React from "react";
import {
    Compass,
    FileText,
    Inbox,
    Briefcase,
    Calendar,
    Users,
    Building2,
    GraduationCap,
} from "lucide-react";

interface Props {}

const navigation = [
    { name: "Explore", href: "/", icon: Compass },
    { name: "Feed", href: "/feed", icon: FileText },
    { name: "Inbox", href: "/inbox", icon: Inbox, badge: 1 },
    { name: "Jobs", href: "/jobs", icon: Briefcase },
    { name: "Events", href: "/events", icon: Calendar },
    { name: "People", href: "/people", icon: Users, isNew: true },
    { name: "Employers", href: "/employers", icon: Building2 },
    { name: "Career center", href: "/career-center", icon: GraduationCap },
];

const Sidebar = (props: Props) => {
    const pathname = window.location.pathname;

    return (
        <aside className="fixed left-0 top-16 bottom-0 w-48 bg-white border-r z-40">
            <nav className="flex flex-col gap-1 p-3">
                {navigation.map((item) => {
                    // check current path
                    const isActive = pathname === item.href;
                    const Icon = item.icon;

                    return (
                        <a
                            key={item.name}
                            href={item.href}
                            className={`
                flex items-center gap-3 px-3 py-2 rounded-lg text-sm font-medium transition-colors
                ${
                    isActive
                        ? "bg-gray-100 text-gray-900"
                        : "text-gray-500 hover:bg-gray-100/50 hover:text-gray-900"
                }
              `}
                        >
                            <Icon className="h-5 w-5 flex-shrink-0" />
                            <span className="flex-1">{item.name}</span>
                            {item.badge && (
                                <span className="flex items-center justify-center w-5 h-5 text-xs font-semibold text-white bg-red-500 rounded-full">
                                    {item.badge}
                                </span>
                            )}
                            {item.isNew && (
                                <span className="px-2 py-0.5 text-xs font-semibold text-green-700 bg-green-100 rounded">
                                    New
                                </span>
                            )}
                        </a>
                    );
                })}
            </nav>
        </aside>
    );
};

export default Sidebar;
